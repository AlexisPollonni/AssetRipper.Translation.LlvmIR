using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIdEC2ImEET_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::FPBits<unsigned long>(unsigned long)")]
internal static partial class fputil_FPBits_double_FPBits_unsigned_long_unsigned_long
{
	public unsafe static void Invoke(void* @this, long x)
	{
		unchecked
		{
			fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_FPRepImpl.Invoke((fputil_internal_FPRepImpl_ucubaq*)@this);
			((fputil_internal_FPStorage_v3nexn*)@this)->val = x;
		}
	}
}
