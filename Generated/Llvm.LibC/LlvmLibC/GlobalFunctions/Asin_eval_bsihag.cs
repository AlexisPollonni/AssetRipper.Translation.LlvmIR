using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Asin_eval_bsihag
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L9asin_evalEd")]
	[DemangledName("__llvm_libc_20_1_2_::asin_eval(double)")]
	[CleanName("Asin_eval")]
	public unsafe static double Invoke([MangledName("xsq")][NativeType("double")] double Xsq)
	{
		double x = 0.0;
		double z = 0.0;
		double y = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &x);
		x = Xsq * Xsq;
		Llvm_lifetime_start_p0.Invoke(8L, &z);
		unchecked
		{
			z = Fputil_polyeval_double_double_double_double_double.Invoke(x, *(double*)ASIN_COEFFS.Pointer, ((double*)ASIN_COEFFS.Pointer)[2L], ((double*)ASIN_COEFFS.Pointer)[4L], ((double*)ASIN_COEFFS.Pointer)[6L], ((double*)ASIN_COEFFS.Pointer)[8L]);
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = Fputil_polyeval_double_double_double_double_double.Invoke(x, ((double*)ASIN_COEFFS.Pointer)[1], ((double*)ASIN_COEFFS.Pointer)[3L], ((double*)ASIN_COEFFS.Pointer)[5L], ((double*)ASIN_COEFFS.Pointer)[7L], ((double*)ASIN_COEFFS.Pointer)[9L]);
			double result = Fputil_multiply_add_double.Invoke(Xsq, y, z);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			return result;
		}
	}
}
