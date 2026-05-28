using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_quick_mult_28ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10quick_multILm28EEENS_10NumberPairIdEERKS3_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::quick_mult<28ul>(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::NumberPair<double>")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* B)
	{
		NumberPair numberPair = default(NumberPair);
		double z = 0.0;
		double num = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_mult_28ul.Invoke(A->Hi, B->Hi);
			NumberPair* num2 = &numberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja2.field_0;
			byte* num3 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Fputil_multiply_add_double.Invoke(A->Hi, B->Lo, numberPair.Lo);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = (numberPair.Lo = Fputil_multiply_add_double.Invoke(A->Lo, B->Hi, z));
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
