using System.Runtime.CompilerServices;

namespace DefragCom;

public sealed unsafe partial class DefragTestPage
{
    public unsafe partial struct IDefragClient : IComIID
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT ChangeNotification(UInt64 notificationId, UInt32 notificationType, void* notificationData)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragClient*, UInt64, UInt32, void*, int>)(lpVtbl[3]))((IDefragClient*)Unsafe.AsPointer(ref this), notificationId, notificationType, notificationData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public IUnknown* GetControllingUnknown()
        {
            return (IUnknown*)((delegate* unmanaged[MemberFunction]<IDefragClient*, int>)(lpVtbl[4]))((IDefragClient*)Unsafe.AsPointer(ref this));
        }

        [GuidRVAGen.Guid("c958543e-b3a0-46ee-8085-4f111910d401")]
        public static partial ref readonly Guid Guid { get; }
    }

    public unsafe partial struct IDefragEnginePriv : IComIID
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT Analyze(
            char* volumeName,
            Guid* param1,
            Guid* param2)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, char*, Guid*, Guid*, uint>)(lpVtbl[5]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), volumeName, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT BootOptimize(
            ushort* volumeName,
            Guid* param1,
            Guid* param2)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ushort*, Guid*, Guid*, uint>)(lpVtbl[6]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), volumeName, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT Cancel(Guid id)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, Guid, uint>)(lpVtbl[7]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT DefragmentFull(
            char* volumeName,
            int flags,
            Guid* param1,
            Guid* param2)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, char*, int, Guid*, Guid*, uint>)(lpVtbl[8]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), volumeName, flags, param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT DefragmentFile(
            ushort* fileName,
            Guid* param)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ushort*, Guid*, uint>)(lpVtbl[9]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), fileName, param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT DefragmentSimple(
            ulong param1,
            void* param2)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, void*, uint>)(lpVtbl[10]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT GetPossibleShrinkSpace(
            ulong param1,
            Guid* param2,
            ulong* param3)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, Guid*, ulong*, uint>)(lpVtbl[11]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT Consolidate(
            ulong param1,
            Guid* param2,
            ulong param3,
            ulong* param4)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, Guid*, ulong, ulong*, uint>)(lpVtbl[12]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT Shrink(
            ulong param1,
            Guid* param2,
            void* param3,
            Guid* param4,
            ulong* param5)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, Guid*, void*, Guid*, ulong*, uint>)(lpVtbl[13]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3, param4, param5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT Retrim(
            ulong param1,
            Guid* param2,
            uint param3,
            ulong param4,
            ulong* param5)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, Guid*, uint, ulong, ulong*, uint>)(lpVtbl[14]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3, param4, param5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT Slabify(
            ulong param1,
            Guid* param2,
            uint param3,
            ulong param4,
            ulong* param5)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, Guid*, uint, ulong, ulong*, uint>)(lpVtbl[15]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3, param4, param5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT SlabifyRetrim(
            ulong param1,
            Guid* param2,
            uint param3,
            ulong param4,
            ulong* param5)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, Guid*, uint, ulong, ulong*, uint>)(lpVtbl[16]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3, param4, param5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT SlabAnalyze(
            ulong param1,
            Guid* param2,
            ulong param3,
            ulong* param4)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, Guid*, ulong, ulong*, uint>)(lpVtbl[17]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LRESULT GetStatus(
            void** param1,
            void** param2,
            uint* param3,
            ulong* param4)
        {
            return (LRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, void**, void**, uint*, ulong*, long>)
                (lpVtbl[18]))((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3, param4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LRESULT GetVolumeStatistics(
            ulong param1,
            void** param2,
            void** param3)
        {
            return (LRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, void**, void**, long>)(lpVtbl[19]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT Register(IDefragClient* client, Guid* param)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, IDefragClient*, Guid*, int>)(lpVtbl[20]))((IDefragEnginePriv*)Unsafe.AsPointer(ref this), client, param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LRESULT Unregister(long param1, long* param2)
        {
            return (LRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, long, long*, long>)(lpVtbl[21]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT WaitForCompletion(
            long param1,
            void** param2,
            long* param3)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, long, void**, long*, int>)(lpVtbl[22]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT DisableAutomaticSleep(long param1, void** param2)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, long, void**, int>)(lpVtbl[23]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2);
        }

        /// <summary>
        /// This function doesn't have clear variable names to be used easily.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LRESULT TierOptimize(
            ulong param1,
            uint* param2,
            ulong* param3)
        {
            return (LRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, uint*, ulong*, long>)(lpVtbl[24]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3);
        }

        /// <summary>
        /// This function doesn't have clear variable names to be used easily.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LRESULT BootOptimize2(
            ulong param1,
            Guid* param2,
            void** param3,
            ulong param4,
            uint* param5)
        {
            return (LRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, ulong, Guid*, void**, ulong, uint*, long>)(lpVtbl[25]))
                ((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param1, param2, param3, param4, param5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT Shutdown(long param)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, long, int>)(lpVtbl[26]))((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT NotifyVolumeChange(long param)
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, long, int>)(lpVtbl[27]))((IDefragEnginePriv*)Unsafe.AsPointer(ref this), param);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HRESULT WaitForEvents()
        {
            return (HRESULT)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, int>)(lpVtbl[28]))((IDefragEnginePriv*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public IUnknown* GetControllingUnknown()
        {
            return (IUnknown*)((delegate* unmanaged[MemberFunction]<IDefragEnginePriv*, int>)(lpVtbl[29]))((IDefragEnginePriv*)Unsafe.AsPointer(ref this));
        }

        [GuidRVAGen.Guid("0C401E84-3083-4764-B6B5-A0DE8FEDD40C")]
        public static partial ref readonly Guid Guid { get; }
    }

    IDefragClient DefragClient;

    public DefragTestPage()
    {
        //InitializeComponent();
        //Load();

        //unsafe
        //{
        //    IDefragEnginePriv engine;

        //    var result = ReRegisterEngine(&engine);
        //    Console.WriteLine($"ReRegister result = {result}");
        //}
    }

    //[GuidRVAGen.Guid("87CB4E0D-2E2F-4235-BC0A-7C62308011F6")]
    //public static partial Guid* CLSID_DefragEngineFactory { get; }


    //public unsafe HRESULT ReRegisterEngine(IDefragEnginePriv* enginePtr)
    //{
    //    // Initialize COM for this thread
    //    var hrInit = PInvoke.CoInitializeEx(null, COINIT.COINIT_APARTMENTTHREADED);

    //    var clsid_DefragEngine = CLSID.CLSID_DefragEngine;
    //    var iid_IDefragEnginePriv = IDefragEnginePriv.Guid;

    //    // CoCreateInstance to create the COM object instance
    //    hrInit = PInvoke.CoCreateInstance(
    //        clsid_DefragEngine,
    //        null,
    //        CLSCTX.CLSCTX_LOCAL_SERVER,
    //        &iid_IDefragEnginePriv,
    //        (void**)&enginePtr);

    //    //if (hrInit.Succeeded)
    //    //{
    //    //    Console.WriteLine("Register success");
    //    //    hrInit = Unregister(enginePtr);
    //    //    if (hrInit.Succeeded)
    //    //    {
    //    //        Console.WriteLine("Unregister success"); 
    //    //        hrInit = Register(enginePtr);
    //    //        Console.WriteLine($"Register result = {hrInit}");
    //    //    } 
    //    //}

    //    return hrInit;
    //}

    //public unsafe HRESULT Register(IDefragEnginePriv* enginePtr)
    //{
    //    if (enginePtr == null)
    //        return HRESULT.E_POINTER;

    //    // Step 1: Get clientUnknown by calling method at vtable offset 0x20 on this
    //    var clientUnknownPtr = DefragClient.GetControllingUnknown();
    //    if (clientUnknownPtr == null)
    //        return HRESULT.E_FAIL;

    //    IUnknown* clientUnknown = clientUnknownPtr;
    //    clientUnknown->AddRef();

    //    // Step 2: QueryInterface for IID_IDefragClient
    //    IDefragClient* defragClient = null;
    //    void* ptr;

    //    HRESULT hr = clientUnknown->QueryInterface(in IDefragClient.Guid, out ptr);

    //    if (hr.Succeeded)
    //    {
    //        defragClient = (IDefragClient*)ptr;
    //    }
    //    clientUnknown->Release();
    //    if (hr.Failed)
    //        return hr;

    //    fixed (IDefragClient* client = &DefragClient)
    //    {
    //        fixed (Guid* iUnknownGuid = &IUnknown.IID_Guid)
    //        {
    //            hr = enginePtr->Register(defragClient, iUnknownGuid);
    //        }
    //    }

    //    // Step 4: Release defragClient
    //    IUnknown* unknown = defragClient->GetControllingUnknown();
    //    if (unknown != null)
    //        unknown->Release();

    //    return hr;
    //}

    //public unsafe HRESULT Unregister(IDefragEnginePriv* enginePtr)
    //{
    //    // Unregister the engine
    //    HRESULT hr = new((int)enginePtr->Unregister(0, null).Value);
    //    return hr;
    //}

    public unsafe void LoadDefragCOM(Guid partitionGuid, Guid diskGUID, string volumePath)
    {
        // Initialize COM for this thread
        var hrInit = PInvoke.CoInitializeEx(IntPtr.Zero, COINIT.COINIT_APARTMENTTHREADED);
        if (hrInit.Failed)
        {
            Console.WriteLine($"CoInitializeEx failed: 0x{hrInit.Value:X8}");
            return;
        }

        object pAuthList;
        object pa2;

        unsafe
        {
            PInvoke.CoInitializeSecurity(
                IntPtr.Zero, 
                -1,
                IntPtr.Zero, 
                IntPtr.Zero, 
                RPC_C_AUTHN_LEVEL.RPC_C_AUTHN_LEVEL_PKT_PRIVACY,
                RPC_C_IMP_LEVEL.RPC_C_IMP_LEVEL_IMPERSONATE,
                IntPtr.Zero,
                EOLE_AUTHENTICATION_CAPABILITIES.EOAC_NONE
            );
            IDefragEnginePriv* enginePtr = null;

            var clsid_DefragEngine = Guid.Parse("d20a3293-3341-4ae8-9aaf-8e397cb63c34");//CLSID.CLSID_DefragEngine);
            var iid_IDefragEnginePriv = IDefragEnginePriv.Guid;

            // CoCreateInstance to create the COM object instance
            hrInit = PInvoke.CoCreateInstance(
                clsid_DefragEngine,
                IntPtr.Zero, 
                CLSCTX.CLSCTX_LOCAL_SERVER,
                &iid_IDefragEnginePriv,
                (void**)&enginePtr);

            if (hrInit.Failed)
            {
                Console.WriteLine($"CoCreateInstance failed: 0x{hrInit.Value:X8}");
                return;
            }

            Console.WriteLine($"CoCreateInstance succeeded. Interface pointer: 0x{(nint)enginePtr:X}");

            var instanceGuid = Guid.NewGuid();


            HRESULT hr;

            fixed (char* pVol = volumePath)
            {
                hr = enginePtr->Analyze(pVol, &partitionGuid, &diskGUID);
                Console.WriteLine($"Analyze result = {hr}");

                hr = enginePtr->DefragmentFull(pVol, 0, &partitionGuid, &diskGUID);
                Console.WriteLine($"DefragmentFull result = {hr}");
            }


            //var hr3 = enginePtr->Cancel(instanceGuid);

            //Console.WriteLine($"Cancel result = {hr3}");
        }
    }


}
