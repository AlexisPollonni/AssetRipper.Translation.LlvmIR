using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_div
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3divERKNS_10NumberPairIdEES4_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::div(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
	public unsafe static Struct_4ydhja Invoke([NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* a, [NativeType("__llvm_libc_20_1_2_::NumberPair<double> const&")] NumberPair* b)
	{
		NumberPair numberPair = default(NumberPair);
		double num = 0.0;
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double num2 = 0.0;
		double num3 = 0.0;
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 1.0 / b->hi;
			numberPair.hi = a->hi * num;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = fputil_exact_mult_27ul.Invoke(b->hi, 0.0 - numberPair.hi);
			NumberPair* num4 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num4 = struct_4ydhja2.field_0;
			byte* num5 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num5 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = fputil_exact_mult_27ul.Invoke(b->lo, 0.0 - numberPair.hi);
			NumberPair* num6 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num6 = struct_4ydhja5.field_0;
			byte* num7 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num7 = struct_4ydhja6.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = a->hi + numberPair2.hi + numberPair2.lo;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = a->lo + numberPair3.hi + numberPair3.lo;
			numberPair.lo = num * (num2 + num3);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_4ydhja*)(&numberPair);
		}
	}
}
