using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class conjugate_double_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9conjugateICdEET_S2_")]
	[DemangledName("double complex __llvm_libc_20_1_2_::conjugate<double complex>(double complex)")]
	[return: NativeType("double complex")]
	public unsafe static Struct_4ydhja Invoke([MangledName("c.coerce0")] double c, [MangledName("c.coerce1")][NativeType("double complex")] double c_c)
	{
		Struct_4ydhja result = default(Struct_4ydhja);
		Struct_4ydhja struct_4ydhja = default(Struct_4ydhja);
		NumberPair numberPair = default(NumberPair);
		struct_4ydhja.field_0 = c;
		struct_4ydhja.field_1 = c_c;
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja2 = cpp_bit_cast_Complex_double_double_complex.Invoke(&struct_4ydhja);
			NumberPair* num = &numberPair;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja2;
			*(double*)num = struct_4ydhja3.field_0;
			byte* num2 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja4 = struct_4ydhja2;
			*(double*)num2 = struct_4ydhja4.field_1;
			numberPair.hi = 0.0 - numberPair.hi;
			Struct_4ydhja struct_4ydhja5 = cpp_bit_cast_double_complex_Complex_double.Invoke(&numberPair);
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja5;
			double field_ = struct_4ydhja6.field_0;
			Struct_4ydhja struct_4ydhja7 = struct_4ydhja5;
			double field_2 = struct_4ydhja7.field_1;
			double* ptr = &result.field_1;
			result.field_0 = field_;
			*ptr = field_2;
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			return result;
		}
	}
}
