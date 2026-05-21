using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_2_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EEC2Em")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::FPStorage(unsigned long)")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned long")] long value)
	{
		unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val = value;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::FPStorage()")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val = 0L;
	}
}
