using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_18tan_evalERKNS_10NumberPairIdEERS2_")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::tan_eval(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double>&)")]
internal static partial class anonymous_namespace_tan_eval_NumberPair_double_const_NumberPair_double
{
	public unsafe static double Invoke(NumberPair* u, NumberPair* result)
	{
		double num = 0.0;
		double y = 0.0;
		double z = 0.0;
		double y2 = 0.0;
		double x = 0.0;
		double x2 = 0.0;
		double y3 = 0.0;
		double num2 = 0.0;
		double b = 0.0;
		NumberPair numberPair = default(NumberPair);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = u->hi * u->hi;
		llvm_lifetime_start_p0.Invoke(8L, &y);
		y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num, 0.021869488536155203, 17.0 / 315.0);
		llvm_lifetime_start_p0.Invoke(8L, &z);
		z = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num, 2.0 / 15.0, 1.0 / 3.0);
		llvm_lifetime_start_p0.Invoke(8L, &y2);
		y2 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num, 2.0 / 3.0, 1.0);
		llvm_lifetime_start_p0.Invoke(8L, &x);
		x = num * u->hi;
		llvm_lifetime_start_p0.Invoke(8L, &x2);
		x2 = num * num;
		llvm_lifetime_start_p0.Invoke(8L, &y3);
		y3 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x2, y, z);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num, y2, 1.0);
		llvm_lifetime_start_p0.Invoke(8L, &b);
		b = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, y3, u->lo * num2);
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_exact_add_true_double_double.Invoke(u->hi, b);
		NumberPair* num3 = &numberPair;
		Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
		unchecked
		{
			*(double*)num3 = struct_4ydhja2.field_0;
			byte* num4 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num4 = struct_4ydhja3.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(result, &numberPair, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, x);
			long val = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
			double result2 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2), 4.440892098500626E-16, 1.9721522630525295E-31);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(8L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &y3);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &x);
			llvm_lifetime_end_p0.Invoke(8L, &y2);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result2;
		}
	}
}
