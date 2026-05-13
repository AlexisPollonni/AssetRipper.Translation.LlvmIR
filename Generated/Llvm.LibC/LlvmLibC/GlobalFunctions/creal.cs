using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class creal
{
	public unsafe static double Invoke([MangledName("x.coerce0")] double x, [MangledName("x.coerce1")] double x_c)
	{
		Struct_4ydhja struct_4ydhja = default(Struct_4ydhja);
		NumberPair numberPair = default(NumberPair);
		struct_4ydhja.field_0 = x;
		struct_4ydhja.field_1 = x_c;
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
			double lo = numberPair.lo;
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			return lo;
		}
	}
}
