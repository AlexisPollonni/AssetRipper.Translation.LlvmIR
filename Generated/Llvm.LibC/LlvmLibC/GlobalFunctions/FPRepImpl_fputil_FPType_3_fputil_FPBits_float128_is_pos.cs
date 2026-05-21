using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_pos
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEE6is_posEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::is_pos() const")]
	public unsafe static bool Invoke(void* @this)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		anon_izyfb8.val = FPStorage_fputil_FPType_3_sign.Invoke(@this);
		bool result = Sign_is_pos.Invoke(&anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		return result;
	}
}
