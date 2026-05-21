using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_exact_add_false
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9exact_addILb0EEENS_10NumberPairIdEEdd")]
	[DemangledName("__llvm_libc_20_1_2_::NumberPair<double> __llvm_libc_20_1_2_::fputil::exact_add<false>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::NumberPair<double>")]
	public unsafe static Struct_4ydhja Invoke([MangledName("a")][NativeType("double")] double A, [MangledName("b")][NativeType("double")] double B)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			llvm_libc_20_1_2_NumberPair.Lo = 0.0;
			llvm_libc_20_1_2_NumberPair.Hi = 0.0;
			llvm_libc_20_1_2_NumberPair.Hi = A + B;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = llvm_libc_20_1_2_NumberPair.Hi - A;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = llvm_libc_20_1_2_NumberPair.Hi - num;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = B - num;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = A - num2;
			llvm_libc_20_1_2_NumberPair.Lo = num3 + num4;
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair);
		}
	}
}
