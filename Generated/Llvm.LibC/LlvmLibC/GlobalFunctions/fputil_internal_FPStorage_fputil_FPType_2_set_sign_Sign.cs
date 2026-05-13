using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE8set_signENS_4SignE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::set_sign(__llvm_libc_20_1_2_::Sign)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_2_set_sign_Sign
{
	public unsafe static void Invoke(void* @this, [MangledName("signVal.coerce")] sbyte signVal)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb8.val = signVal;
		anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(@this);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
		if (operator_Sign_Sign_rpctvi.Invoke(anon_izyfb9.val, anon_izyfb10.val))
		{
			unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val ^= long.MinValue;
		}
	}
}
