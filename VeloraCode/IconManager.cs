using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VeloraCode;

public static class IconManager
{
    private static readonly Dictionary<string, string> cache = new Dictionary<string, string>();

    public static string GetIconKey(string path, bool isFolder, Main form)
    {
        if (cache.ContainsKey(path))
            return cache[path];

        Icon icon = isFolder ? GetFolderIcon() : GetFileIcon(path);

        string key = path;

        if (!form.imageList1.Images.ContainsKey(key))
            form.imageList1.Images.Add(key, icon);

        cache[path] = key;
        return key;
    }

    // ------------------------------------------------------------------
    // Obtener icono de archivo
    // ------------------------------------------------------------------
    private static Icon GetFileIcon(string filePath)
    {
        SHFILEINFO shinfo = new SHFILEINFO();

        IntPtr hImg = SHGetFileInfo(filePath, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo),
            SHGFI_ICON | SHGFI_LARGEICON | SHGFI_USEFILEATTRIBUTES);

        Icon icon = (Icon)Icon.FromHandle(shinfo.hIcon).Clone();
        DestroyIcon(shinfo.hIcon);

        return icon;
    }

    // ------------------------------------------------------------------
    // Obtener icono real de carpeta
    // ------------------------------------------------------------------
    private static Icon GetFolderIcon()
    {
        SHFILEINFO shinfo = new SHFILEINFO();

        IntPtr hImg = SHGetFileInfo(null, FILE_ATTRIBUTE_DIRECTORY, ref shinfo,
            (uint)Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_LARGEICON);

        Icon icon = (Icon)Icon.FromHandle(shinfo.hIcon).Clone();
        DestroyIcon(shinfo.hIcon);

        return icon;
    }

    // ------------------------------------------------------------------
    // Interop con Windows Shell
    // ------------------------------------------------------------------
    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEINFO
    {
        public IntPtr hIcon;
        public int iIcon;
        public uint dwAttributes;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    };

    [DllImport("shell32.dll")]
    public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes,
        ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

    [DllImport("user32.dll")]
    public static extern bool DestroyIcon(IntPtr handle);

    private const uint SHGFI_ICON = 0x100;
    private const uint SHGFI_DISPLAYNAME = 0x200;
    private const uint SHGFI_TYPENAME = 0x400;
    private const uint SHGFI_LARGEICON = 0x0;
    private const uint SHGFI_SMALLICON = 0x1;
    private const uint SHGFI_USEFILEATTRIBUTES = 0x10;
    private const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
}
