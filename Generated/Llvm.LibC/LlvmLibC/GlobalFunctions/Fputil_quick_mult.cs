using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_quick_mult
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10quick_multEdRKNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::quick_mult(double, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("double")] double A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* B)
	{
		NumberPair numberPair = default(NumberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_mult_27ul.Invoke(A, B->Hi);
			NumberPair* num = &numberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num = struct_4ydhja2.field_0;
			byte* num2 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja3.field_1;
			numberPair.Lo = Fputil_multiply_add_double.Invoke(A, B->Lo, numberPair.Lo);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
