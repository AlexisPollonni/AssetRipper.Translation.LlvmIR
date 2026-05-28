using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_add
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3addERKNS_10NumberPairIdEES4_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::add(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* A, [MangledName("b")][NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* B)
	{
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		double num = 0.0;
		Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
		unchecked
		{
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(A->Hi, B->Hi);
			NumberPair* num2 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num2 = struct_4ydhja2.field_0;
			byte* num3 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num3 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = A->Lo + B->Lo;
			Struct_4ydhja struct_4ydhja4 = Fputil_exact_add_true.Invoke(numberPair2.Hi, numberPair2.Lo + num);
			NumberPair* num4 = &numberPair;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num4 = struct_4ydhja5.field_0;
			byte* num5 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num5 = struct_4ydhja6.field_1;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
