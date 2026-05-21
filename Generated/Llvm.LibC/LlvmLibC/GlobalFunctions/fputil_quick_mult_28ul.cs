using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_quick_mult_28ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10quick_multILm28EEENS_10NumberPairIdEERKS3_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::quick_mult<28ul>(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::NumberPair<double>")]
	public unsafe static Struct_4ydhja Invoke([NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* a, [NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* b)
	{
		NumberPair numberPair = default(NumberPair);
		double z = 0.0;
		double num = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = fputil_exact_mult_28ul.Invoke(a->hi, b->hi);
			NumberPair* num2 = &numberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja2.field_0;
			byte* num3 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = fputil_multiply_add_double.Invoke(a->hi, b->lo, numberPair.lo);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = (numberPair.lo = fputil_multiply_add_double.Invoke(a->lo, b->hi, z));
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
