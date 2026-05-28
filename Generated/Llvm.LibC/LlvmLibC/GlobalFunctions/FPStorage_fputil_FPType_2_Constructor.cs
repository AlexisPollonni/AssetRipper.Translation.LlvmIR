using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_2_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EEC2Em")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::FPStorage(unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("unsigned long")] long Value)
	{
		unchecked((Fputil_internal_FPStorage_v3nexn*)This)->Val = Value;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::FPStorage()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked((Fputil_internal_FPStorage_v3nexn*)This)->Val = 0L;
	}
}
