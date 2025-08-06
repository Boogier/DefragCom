using System.Runtime.InteropServices;

namespace DefragCom;

public interface IComIID
{
    static abstract ref readonly Guid Guid { get; }
}

public unsafe class PInvoke
{
    [DllImport("ole32.dll", SetLastError = false, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
    public static extern HRESULT CoCreateInstance(
        [In, MarshalAs(UnmanagedType.LPStruct)] Guid rclsid,
        [In, Optional] IntPtr pUnkOuter,
        [In] CLSCTX dwClsContext,
        Guid* riid,
        void** ppv
    );

    [DllImport("ole32.dll", ExactSpelling = true, CallingConvention = CallingConvention.StdCall, SetLastError = false)]
    public static extern HRESULT CoInitializeEx(
        [Optional] IntPtr pvReserved,
        COINIT coInit);

    [DllImport("ole32.dll", SetLastError = false, CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
    public static extern HRESULT CoInitializeSecurity(
        [Optional] IntPtr pSecDesc,
        int cAuthSvc,
        IntPtr asAuthSvc,
        [Optional] IntPtr pReserved1,
        RPC_C_AUTHN_LEVEL dwAuthnLevel,
        RPC_C_IMP_LEVEL dwImpLevel,
        IntPtr pAuthList,
        EOLE_AUTHENTICATION_CAPABILITIES dwCapabilities,
        [Optional] IntPtr pReserved3
    );

}

[Flags]
public enum RPC_C_AUTHN_LEVEL : uint
{
    Default = 0,
    None = 1,
    Connect = 2,
    Call = 3,
    Pkt = 4,
    PktIntegrity = 5,
    RPC_C_AUTHN_LEVEL_PKT_PRIVACY = 6
}

[Flags]
public enum RPC_C_IMP_LEVEL : uint
{
    Default = 0,
    Anonymous = 1,
    Identify = 2,
    RPC_C_IMP_LEVEL_IMPERSONATE = 3,
    Delegate = 4
}

[Flags]
public enum EOLE_AUTHENTICATION_CAPABILITIES : uint
{
    EOAC_NONE = 0x00,
    MutualAuth = 0x01,
    StaticCloaking = 0x20,
    DynamicCloaking = 0x40,
    AnyAuthority = 0x80,
    MakeFullSIC = 0x100,
    Default = 0x800,
    SecureRefs = 0x02,
    AccessControl = 0x04,
    AppID = 0x08,
    Dynamic = 0x10,
    RequireFullSIC = 0x200,
    AutoImpersonate = 0x400,
    NoCustomMarshal = 0x2000,
    DisableAAA = 0x1000
}

[Flags]
public enum COINIT : uint
{
    /// <summary>Initializes the thread for multi-threaded object concurrency.</summary>
    COINIT_MULTITHREADED = 0x0,
    /// <summary>Initializes the thread for apartment-threaded object concurrency.</summary>
    COINIT_APARTMENTTHREADED = 0x2,
    /// <summary>Disables DDE for OLE1 support.</summary>
    COINIT_DISABLE_OLE1DDE = 0x4,
    /// <summary>Trade memory for speed.</summary>
    COINIT_SPEED_OVER_MEMORY = 0x8,
}

[Flags]
public enum CLSCTX : uint
{
    CLSCTX_INPROC_SERVER = 0x1,
    CLSCTX_INPROC_HANDLER = 0x2,
    CLSCTX_LOCAL_SERVER = 0x4,
    CLSCTX_INPROC_SERVER16 = 0x8,
    CLSCTX_REMOTE_SERVER = 0x10,
    CLSCTX_INPROC_HANDLER16 = 0x20,
    CLSCTX_RESERVED1 = 0x40,
    CLSCTX_RESERVED2 = 0x80,
    CLSCTX_RESERVED3 = 0x100,
    CLSCTX_RESERVED4 = 0x200,
    CLSCTX_NO_CODE_DOWNLOAD = 0x400,
    CLSCTX_RESERVED5 = 0x800,
    CLSCTX_NO_CUSTOM_MARSHAL = 0x1000,
    CLSCTX_ENABLE_CODE_DOWNLOAD = 0x2000,
    CLSCTX_NO_FAILURE_LOG = 0x4000,
    CLSCTX_DISABLE_AAA = 0x8000,
    CLSCTX_ENABLE_AAA = 0x10000,
    CLSCTX_FROM_DEFAULT_CONTEXT = 0x20000,
    CLSCTX_INPROC = CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER,
    CLSCTX_SERVER = CLSCTX_INPROC_SERVER | CLSCTX_LOCAL_SERVER | CLSCTX_REMOTE_SERVER,
    CLSCTX_ALL = CLSCTX_SERVER | CLSCTX_INPROC_HANDLER
}
[ComImport]
[Guid("00000000-0000-0000-C000-000000000046")]
public interface IUnknown
{
    [PreserveSig]
    HRESULT QueryInterface([In] ref Guid riid, out IntPtr ppvObject);

    [PreserveSig]
    uint AddRef();

    [PreserveSig]
    uint Release();
}

