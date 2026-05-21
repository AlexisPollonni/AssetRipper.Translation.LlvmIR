using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_shift_right
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE11shift_rightEj")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::shift_right(unsigned int)")]
	public unsafe static Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* This, [MangledName("shift_length")][NativeType("unsigned int")] int Shift_length)
	{
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		unchecked
		{
			if ((ulong)(uint)Shift_length < 128uL)
			{
				checked
				{
					This->Exponent += Shift_length;
				}
				BigInt_128ul_false_unsigned_long_Operator_srrb86.Invoke((Anon_izyfb7*)(&This->Mantissa), (uint)Shift_length);
			}
			else
			{
				This->Exponent = 0;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
				BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), 0);
				Llvm_memcpy_p0_p0_i64.Invoke(&This->Mantissa, &llvm_libc_20_1_2_BigInt_qdkjbh, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
			}
			return This;
		}
	}
}
