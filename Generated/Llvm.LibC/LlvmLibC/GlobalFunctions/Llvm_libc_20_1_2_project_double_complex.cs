using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_project_double_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7projectICdEET_S2_")]
	[DemangledName("double complex __llvm_libc_20_1_2_::project<double complex>(double complex)")]
	[return: NativeType("double complex")]
	public unsafe static Struct_4ydhja Invoke([MangledName("c.coerce0")] double C, [MangledName("c.coerce1")][NativeType("double complex")] double C_c)
	{
		Struct_4ydhja result = default(Struct_4ydhja);
		Struct_4ydhja struct_4ydhja = default(Struct_4ydhja);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		struct_4ydhja.field_0 = C;
		struct_4ydhja.field_1 = C_c;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja2 = Cpp_bit_cast_Complex_double_double_complex.Invoke(&struct_4ydhja);
			Llvm_libc_20_1_2_NumberPair* num = &llvm_libc_20_1_2_NumberPair;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja2;
			*(double*)num = struct_4ydhja3.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
			Struct_4ydhja struct_4ydhja4 = struct_4ydhja2;
			*(double*)num2 = struct_4ydhja4.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, llvm_libc_20_1_2_NumberPair.Lo);
			bool num3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			int num4;
			if (num3)
			{
				num4 = -1;
			}
			else
			{
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, llvm_libc_20_1_2_NumberPair.Hi);
				num4 = (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2)) ? 1 : 0);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			if (num4 != 0)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb.Val);
				llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val;
				llvm_libc_20_1_2_NumberPair2.Lo = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				llvm_libc_20_1_2_NumberPair2.Hi = InstructionHelper.Select(llvm_libc_20_1_2_NumberPair.Hi > 0.0, 0.0, -0.0);
				Struct_4ydhja struct_4ydhja5 = Cpp_bit_cast_double_complex_Complex_double.Invoke(&llvm_libc_20_1_2_NumberPair2);
				Struct_4ydhja struct_4ydhja6 = struct_4ydhja5;
				double field_ = struct_4ydhja6.field_0;
				Struct_4ydhja struct_4ydhja7 = struct_4ydhja5;
				double field_2 = struct_4ydhja7.field_1;
				double* ptr = &result.field_1;
				result.field_0 = field_;
				*ptr = field_2;
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			}
			else
			{
				double field_3 = struct_4ydhja.field_0;
				double field_4 = struct_4ydhja.field_1;
				double* ptr2 = &result.field_1;
				result.field_0 = field_3;
				*ptr2 = field_4;
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			return result;
		}
	}
}
