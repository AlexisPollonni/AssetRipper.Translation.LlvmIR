using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L9asin_evalEd")]
[DemangledName("__llvm_libc_20_1_2_::asin_eval(double)")]
internal static partial class asin_eval_double
{
	public unsafe static double Invoke(double xsq)
	{
		double x = 0.0;
		double z = 0.0;
		double y = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &x);
		x = xsq * xsq;
		llvm_lifetime_start_p0.Invoke(8L, &z);
		unchecked
		{
			z = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double_double_double.Invoke(x, *(double*)ASIN_COEFFS.Pointer, ((double*)ASIN_COEFFS.Pointer)[2L], ((double*)ASIN_COEFFS.Pointer)[4L], ((double*)ASIN_COEFFS.Pointer)[6L], ((double*)ASIN_COEFFS.Pointer)[8L]);
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double_double_double.Invoke(x, ((double*)ASIN_COEFFS.Pointer)[1], ((double*)ASIN_COEFFS.Pointer)[3L], ((double*)ASIN_COEFFS.Pointer)[5L], ((double*)ASIN_COEFFS.Pointer)[7L], ((double*)ASIN_COEFFS.Pointer)[9L]);
			double result = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(xsq, y, z);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &x);
			return result;
		}
	}
}
