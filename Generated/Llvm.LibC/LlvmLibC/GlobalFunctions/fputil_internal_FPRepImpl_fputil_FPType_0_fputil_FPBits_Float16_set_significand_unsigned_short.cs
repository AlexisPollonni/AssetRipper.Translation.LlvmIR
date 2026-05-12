using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE15set_significandEt")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::set_significand(unsigned short)")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_significand_unsigned_short
{
	public unsafe static void Invoke(fputil_internal_FPRepImpl_7z3gh9* @this, short sigVal)
	{
		short b = sigVal;
		unchecked
		{
			((fputil_internal_FPStorage_za9n4f*)@this)->field_0 = fputil_internal_FPStorage_fputil_FPType_0_merge_unsigned_short_unsigned_short_unsigned_short.Invoke(((fputil_internal_FPStorage_za9n4f*)@this)->field_0, b, 1023);
		}
	}
}
