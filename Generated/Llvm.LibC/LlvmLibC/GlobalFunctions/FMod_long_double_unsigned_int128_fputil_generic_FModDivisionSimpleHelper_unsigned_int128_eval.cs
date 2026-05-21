using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_long_double_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIeoNS1_24FModDivisionSimpleHelperIoEEE4evalEee")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<long double, unsigned __int128, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned __int128>>::eval(long double, long double)")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("y")][NativeType("long double")] double Y)
	{
		double result = 0.0;
		double num = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi3 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi4 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi5 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(16L, &num);
		num = double.NaN;
		int num2;
		if (Details_expects_bool_condition_bool.Invoke(FMod_long_double_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_pre_check.Invoke(X, Y, &num), Expected: false))
		{
			result = num;
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		Llvm_lifetime_end_p0.Invoke(16L, &num);
		unchecked
		{
			switch (num2)
			{
			case 0:
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
				FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
				*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2) = -6148914691236517206L;
				FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, Y);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				*(sbyte*)(&anon_izyfb) = -86;
				anon_izyfb.Val = FPStorage_fputil_FPType_4_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_4_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, anon_izyfb2.Val);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_4_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, anon_izyfb3.Val);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
				*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3) = -6148914691236517206L;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi4, &llvm_libc_20_1_2_fputil_FPBits_ubgsi, 16L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi5, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2, 16L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = FMod_long_double_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_eval_internal.Invoke(*(long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi4), ((long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi4))[1], *(long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi5), ((long*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi5))[1]);
				Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, &anon_izyfb, 1L, isVolatile: false);
				FPStorage_fputil_FPType_4_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3, anon_izyfb4.Val);
				result = FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				goto case 1;
			}
			case 1:
				return result;
			default:
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
	}
}
