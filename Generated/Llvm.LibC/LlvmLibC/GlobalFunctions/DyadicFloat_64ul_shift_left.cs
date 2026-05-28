using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_shift_left
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EE10shift_leftEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::shift_left(unsigned int)")]
	public unsafe static Fputil_DyadicFloat_syracv* Invoke([MangledName("this")] Fputil_DyadicFloat_syracv* This, [MangledName("shift_length")][NativeType("unsigned int")] int Shift_length)
	{
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		if (unchecked((ulong)(uint)Shift_length) < 64uL)
		{
			This->Exponent -= Shift_length;
			BigInt_64ul_false_unsigned_long_Operator_pq2pm2.Invoke(&This->Mantissa, unchecked((uint)Shift_length));
		}
		else
		{
			This->Exponent = 0;
			Llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs);
			BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_555ggs, 0);
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &bigInt_555ggs, 8L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs);
		}
		return This;
	}
}
