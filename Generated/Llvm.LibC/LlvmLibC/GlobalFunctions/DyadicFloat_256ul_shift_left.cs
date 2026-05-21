using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_256ul_shift_left
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm256EE10shift_leftEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<256ul>::shift_left(unsigned int)")]
	public unsafe static Llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj* Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_jhcpjj* This, [MangledName("shift_length")][NativeType("unsigned int")] int Shift_length)
	{
		Llvm_libc_20_1_2_BigInt_x9dsed llvm_libc_20_1_2_BigInt_x9dsed = default(Llvm_libc_20_1_2_BigInt_x9dsed);
		if (unchecked((ulong)(uint)Shift_length) < 256uL)
		{
			This->Exponent -= Shift_length;
			BigInt_256ul_false_unsigned_long_Operator_d84zyi.Invoke(&This->Mantissa, unchecked((uint)Shift_length));
		}
		else
		{
			This->Exponent = 0;
			Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed);
			BigInt_256ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_x9dsed, 0);
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &llvm_libc_20_1_2_BigInt_x9dsed, 32L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_BigInt_x9dsed);
		}
		return This;
	}
}
