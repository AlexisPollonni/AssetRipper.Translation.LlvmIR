using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_long_double_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_pre_check
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIeoNS1_24FModDivisionSimpleHelperIoEEE9pre_checkEeeRe")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<long double, unsigned __int128, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned __int128>>::pre_check(long double, long double, long double&)")]
	public unsafe static bool Invoke([NativeType("long double")] double x, [NativeType("long double")] double y, [NativeType("long double&")] void* @out)
	{
		double num = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &num);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
		sbyte val = anon_izyfb8.val;
		Int128 @int = 0L;
		unchecked
		{
			Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val, *(long*)(&@int), ((long*)(&@int))[1]);
			Int128* ptr = &fputil_FPBits_ubgsi3.val.Data.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			double num2 = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			num = num2;
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi4, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			*(Int128*)(&fputil_FPBits_ubgsi5) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi5, y);
			bool result;
			if (details_expects_bool_condition_bool.Invoke(!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi5) && ((!FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi5)) ? ((byte)((FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan.Invoke(&fputil_FPBits_ubgsi4) ? 1u : 0u) ^ 0xFFFFFFFFu) != 0) : false), expected: true))
			{
				result = false;
			}
			else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi4) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&fputil_FPBits_ubgsi5))
			{
				if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi4) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi5))
				{
					fputil_raise_except_if_required.Invoke(1);
				}
				*(double*)@out = double.NaN;
				result = true;
			}
			else if (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&fputil_FPBits_ubgsi4) || FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_zero.Invoke(&fputil_FPBits_ubgsi5))
			{
				fputil_raise_except_if_required.Invoke(1);
				fputil_set_errno_if_required.Invoke(33);
				*(double*)@out = double.NaN;
				result = true;
			}
			else
			{
				*(double*)@out = x;
				result = true;
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &num);
			return result;
		}
	}
}
