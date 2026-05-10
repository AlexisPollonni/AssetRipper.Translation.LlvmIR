using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12canonicalizeIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRS4_RKS4_")]
[DemangledName("int __llvm_libc_20_1_2_::fputil::canonicalize<__float128, 0>(__float128&, __float128 const&)")]
internal static partial class int_fputil_canonicalize_float128_0_float128_float128_const
{
	public unsafe static int Invoke(void* cx, void* x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, *(double*)x);
			int result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke(&fputil_FPBits_ubgsi3), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_3_sign_const.Invoke(&fputil_FPBits_ubgsi3);
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_get_explicit_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
				Int128* num = &@int;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num = struct_fiz2nb2.field_0;
				byte* num2 = (byte*)(&@int) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb3.field_1;
				Int128 int3 = @int;
				sbyte val = anon_izyfb8.val;
				int2 = int3;
				Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_quiet_nan_Sign_unsigned_int128.Invoke(val, *(long*)(&int2), ((long*)(&int2))[1]);
				Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
				Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
				*(double*)cx = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi4);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				fputil_raise_except_if_required_int.Invoke(1);
				result = 1;
			}
			else
			{
				*(double*)cx = *(double*)x;
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
