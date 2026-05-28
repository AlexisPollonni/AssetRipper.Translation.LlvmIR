using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DigitBuffer_unsigned_int128_10_push
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal11DigitBufferIoLi10EE4pushEc")]
	[DemangledName("__llvm_libc_20_1_2_::internal::DigitBuffer<unsigned __int128, 10>::push(char)")]
	public unsafe static void Invoke([MangledName("this")] Internal_DigitBuffer_wha8ym* This, [MangledName("c")][NativeType("char")] sbyte C)
	{
		int num = 0;
		sbyte b = 0;
		sbyte b2 = C;
		unchecked
		{
			if (b2 != 39)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = Internal_b36_char_to_int_wusq6b.Invoke(b2);
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (sbyte)((num >= 10 || (num == 0 && b2 != 48)) ? 255 : num);
				if ((byte)b == byte.MaxValue || (ulong)This->Size >= 42uL)
				{
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
				sbyte b3 = b;
				((sbyte*)(&This->Digits))[This->Size] = b3;
				This->Size++;
				Llvm_lifetime_end_p0.Invoke(1L, &b);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
