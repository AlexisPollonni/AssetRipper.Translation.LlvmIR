using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L9atan_evalEdj")]
[DemangledName("__llvm_libc_20_1_2_::atan_eval(double, unsigned int)")]
internal static partial class atan_eval_double_unsigned_int
{
	public unsafe static double Invoke(double x, int i)
	{
		double num = 0.0;
		double z = 0.0;
		double y = 0.0;
		double z2 = 0.0;
		double y2 = 0.0;
		double x2 = 0.0;
		double z3 = 0.0;
		double y3 = 0.0;
		double num2 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = x * x;
		llvm_lifetime_start_p0.Invoke(8L, &z);
		unchecked
		{
			z = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)i * (nint)sizeof(InlineArray9_Double)))[2L], ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)i * (nint)sizeof(InlineArray9_Double)))[1]);
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)i * (nint)sizeof(InlineArray9_Double)))[4L], ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)i * (nint)sizeof(InlineArray9_Double)))[3L]);
			llvm_lifetime_start_p0.Invoke(8L, &z2);
			z2 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)i * (nint)sizeof(InlineArray9_Double)))[6L], ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)i * (nint)sizeof(InlineArray9_Double)))[5L]);
			llvm_lifetime_start_p0.Invoke(8L, &y2);
			y2 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)i * (nint)sizeof(InlineArray9_Double)))[8L], ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)i * (nint)sizeof(InlineArray9_Double)))[7L]);
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num * num;
			llvm_lifetime_start_p0.Invoke(8L, &z3);
			z3 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num, y, z);
			llvm_lifetime_start_p0.Invoke(8L, &y3);
			y3 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num, y2, z2);
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x2, y3, z3);
			double result = num2;
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &y3);
			llvm_lifetime_end_p0.Invoke(8L, &z3);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &y2);
			llvm_lifetime_end_p0.Invoke(8L, &z2);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
