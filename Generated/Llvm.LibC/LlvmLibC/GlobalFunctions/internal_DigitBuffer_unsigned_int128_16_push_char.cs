using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal11DigitBufferIoLi16EE4pushEc")]
[DemangledName("__llvm_libc_20_1_2_::internal::DigitBuffer<unsigned __int128, 16>::push(char)")]
internal static partial class internal_DigitBuffer_unsigned_int128_16_push_char
{
	public unsafe static void Invoke(internal_DigitBuffer_cze9ca* @this, sbyte c)
	{
		int num = 0;
		sbyte b = 0;
		sbyte b2 = c;
		unchecked
		{
			if (b2 != 39)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = internal_b36_char_to_int_int_37.Invoke(b2);
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (sbyte)((num >= 16 || (num == 0 && b2 != 48)) ? 255 : num);
				if ((byte)b == byte.MaxValue || (ulong)@this->size >= 32uL)
				{
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
				sbyte b3 = b;
				((sbyte*)(&@this->digits))[@this->size] = b3;
				@this->size++;
				llvm_lifetime_end_p0.Invoke(1L, &b);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
