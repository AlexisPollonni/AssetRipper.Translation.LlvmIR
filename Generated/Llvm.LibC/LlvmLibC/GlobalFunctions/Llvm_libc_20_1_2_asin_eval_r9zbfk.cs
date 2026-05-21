using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_asin_eval_r9zbfk
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L9asin_evalEd.97")]
	[DemangledName("__llvm_libc_20_1_2_::asin_eval(double) (.97)")]
	[CleanName("Llvm_libc_20_1_2_asin_eval")]
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
			z = Fputil_polyeval_double_double_double_double_double.Invoke(x, *(double*)Llvm_libc_20_1_2_ASIN_COEFFS_98.Pointer, ((double*)Llvm_libc_20_1_2_ASIN_COEFFS_98.Pointer)[2L], ((double*)Llvm_libc_20_1_2_ASIN_COEFFS_98.Pointer)[4L], ((double*)Llvm_libc_20_1_2_ASIN_COEFFS_98.Pointer)[6L], ((double*)Llvm_libc_20_1_2_ASIN_COEFFS_98.Pointer)[8L]);
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = Fputil_polyeval_double_double_double_double_double.Invoke(x, ((double*)Llvm_libc_20_1_2_ASIN_COEFFS_98.Pointer)[1], ((double*)Llvm_libc_20_1_2_ASIN_COEFFS_98.Pointer)[3L], ((double*)Llvm_libc_20_1_2_ASIN_COEFFS_98.Pointer)[5L], ((double*)Llvm_libc_20_1_2_ASIN_COEFFS_98.Pointer)[7L], ((double*)Llvm_libc_20_1_2_ASIN_COEFFS_98.Pointer)[9L]);
			double result = Fputil_multiply_add_double.Invoke(Xsq, y, z);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			return result;
		}
	}
}
