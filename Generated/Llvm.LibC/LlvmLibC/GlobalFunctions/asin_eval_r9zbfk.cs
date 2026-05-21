using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class asin_eval_r9zbfk
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L9asin_evalEd.97")]
	[DemangledName("__llvm_libc_20_1_2_::asin_eval(double) (.97)")]
	[CleanName("asin_eval")]
	public unsafe static double Invoke([NativeType("double")] double xsq)
	{
		double x = 0.0;
		double z = 0.0;
		double y = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &x);
		x = xsq * xsq;
		llvm_lifetime_start_p0.Invoke(8L, &z);
		unchecked
		{
			z = fputil_polyeval_double_double_double_double_double.Invoke(x, *(double*)ASIN_COEFFS_98.Pointer, ((double*)ASIN_COEFFS_98.Pointer)[2L], ((double*)ASIN_COEFFS_98.Pointer)[4L], ((double*)ASIN_COEFFS_98.Pointer)[6L], ((double*)ASIN_COEFFS_98.Pointer)[8L]);
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = fputil_polyeval_double_double_double_double_double.Invoke(x, ((double*)ASIN_COEFFS_98.Pointer)[1], ((double*)ASIN_COEFFS_98.Pointer)[3L], ((double*)ASIN_COEFFS_98.Pointer)[5L], ((double*)ASIN_COEFFS_98.Pointer)[7L], ((double*)ASIN_COEFFS_98.Pointer)[9L]);
			double result = fputil_multiply_add_double.Invoke(xsq, y, z);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &x);
			return result;
		}
	}
}
