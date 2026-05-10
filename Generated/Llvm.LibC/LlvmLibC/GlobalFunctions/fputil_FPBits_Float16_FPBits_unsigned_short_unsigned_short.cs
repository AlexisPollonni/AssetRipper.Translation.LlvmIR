using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIDF16_EC2ItEET_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::FPBits<unsigned short>(unsigned short)")]
internal static partial class fputil_FPBits_Float16_FPBits_unsigned_short_unsigned_short
{
	public unsafe static void Invoke(void* @this, short x)
	{
		short field_ = x;
		fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_FPRepImpl.Invoke(@this);
		unchecked((fputil_internal_FPStorage_za9n4f*)@this)->field_0 = field_;
	}
}
