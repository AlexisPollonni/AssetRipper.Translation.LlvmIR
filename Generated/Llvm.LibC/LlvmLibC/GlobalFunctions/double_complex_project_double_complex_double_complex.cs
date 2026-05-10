using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7projectICdEET_S2_")]
[DemangledName("double complex __llvm_libc_20_1_2_::project<double complex>(double complex)")]
internal static partial class double_complex_project_double_complex_double_complex
{
	public unsafe static Struct_4ydhja Invoke([MangledName("c.coerce0")] double c, [MangledName("c.coerce1")] double c_c)
	{
		Struct_4ydhja result = default(Struct_4ydhja);
		Struct_4ydhja struct_4ydhja = default(Struct_4ydhja);
		NumberPair numberPair = default(NumberPair);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		NumberPair numberPair2 = default(NumberPair);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		struct_4ydhja.field_0 = c;
		struct_4ydhja.field_1 = c_c;
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja2 = cpp_enable_if_sizeof_Complex_double_sizeof_double_complex_cpp_is_trivially_constructible_Complex_double_value_cpp_is_trivially_copyable_Complex_double_value_cpp_is_trivially_copyable_double_complex_value_Complex_double_type_cpp_bit_cast_Complex_double_double_complex_double_complex_const.Invoke(&struct_4ydhja);
			NumberPair* num = &numberPair;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja2;
			*(double*)num = struct_4ydhja3.field_0;
			byte* num2 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja4 = struct_4ydhja2;
			*(double*)num2 = struct_4ydhja4.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, numberPair.lo);
			bool num3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			int num4;
			if (num3)
			{
				num4 = -1;
			}
			else
			{
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, numberPair.hi);
				num4 = (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke(&fputil_FPBits_wjhbrm3) ? 1 : 0);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			if (num4 != 0)
			{
				llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb8.val);
				fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val;
				numberPair2.lo = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4);
				numberPair2.hi = InstructionHelper.Select(numberPair.hi > 0.0, 0.0, -0.0);
				Struct_4ydhja struct_4ydhja5 = cpp_enable_if_sizeof_double_complex_sizeof_Complex_double_cpp_is_trivially_constructible_double_complex_value_cpp_is_trivially_copyable_double_complex_value_cpp_is_trivially_copyable_Complex_double_value_double_complex_type_cpp_bit_cast_double_complex_Complex_double_Complex_double_const.Invoke(&numberPair2);
				Struct_4ydhja struct_4ydhja6 = struct_4ydhja5;
				double field_ = struct_4ydhja6.field_0;
				Struct_4ydhja struct_4ydhja7 = struct_4ydhja5;
				double field_2 = struct_4ydhja7.field_1;
				double* ptr = &result.field_1;
				result.field_0 = field_;
				*ptr = field_2;
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			}
			else
			{
				double field_3 = struct_4ydhja.field_0;
				double field_4 = struct_4ydhja.field_1;
				double* ptr2 = &result.field_1;
				result.field_0 = field_3;
				*ptr2 = field_4;
			}
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			return result;
		}
	}
}
