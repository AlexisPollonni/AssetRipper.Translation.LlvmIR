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
	public unsafe static double Invoke([NativeType("long double")] double x, [NativeType("long double")] double y)
	{
		double result = 0.0;
		double num = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(16L, &num);
		num = double.NaN;
		int num2;
		if (details_expects_bool_condition_bool.Invoke(FMod_long_double_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_pre_check.Invoke(x, y, &num), expected: false))
		{
			result = num;
			num2 = 1;
		}
		else
		{
			num2 = 0;
		}
		llvm_lifetime_end_p0.Invoke(16L, &num);
		unchecked
		{
			switch (num2)
			{
			case 0:
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
				FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
				FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi4, y);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				*(sbyte*)(&anon_izyfb8) = -86;
				anon_izyfb8.val = FPStorage_fputil_FPType_4_sign.Invoke(&fputil_FPBits_ubgsi3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_4_set_sign.Invoke(&fputil_FPBits_ubgsi3, anon_izyfb9.val);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_4_set_sign.Invoke(&fputil_FPBits_ubgsi4, anon_izyfb10.val);
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				*(Int128*)(&fputil_FPBits_ubgsi5) = -6148914691236517206L;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi6, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi7, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = FMod_long_double_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_eval_internal.Invoke(*(long*)(&fputil_FPBits_ubgsi6), ((long*)(&fputil_FPBits_ubgsi6))[1], *(long*)(&fputil_FPBits_ubgsi7), ((long*)(&fputil_FPBits_ubgsi7))[1]);
				Int128* ptr = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, &anon_izyfb8, 1L, isVolatile: false);
				FPStorage_fputil_FPType_4_set_sign.Invoke(&fputil_FPBits_ubgsi5, anon_izyfb11.val);
				result = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi5);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
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
