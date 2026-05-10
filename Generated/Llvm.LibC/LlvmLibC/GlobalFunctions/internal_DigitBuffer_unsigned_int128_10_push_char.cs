using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal11DigitBufferIoLi10EE4pushEc")]
[DemangledName("__llvm_libc_20_1_2_::internal::DigitBuffer<unsigned __int128, 10>::push(char)")]
internal static partial class internal_DigitBuffer_unsigned_int128_10_push_char
{
	public unsafe static void Invoke(void* @this, sbyte c)
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
				b = (sbyte)((num >= 10 || (num == 0 && b2 != 48)) ? 255 : num);
				if ((byte)b == byte.MaxValue || (ulong)((internal_DigitBuffer_wha8ym*)@this)->size >= 42uL)
				{
					throw null;
				}
				sbyte b3 = b;
				((sbyte*)(&((internal_DigitBuffer_wha8ym*)@this)->digits))[((internal_DigitBuffer_wha8ym*)@this)->size] = b3;
				((internal_DigitBuffer_wha8ym*)@this)->size++;
				llvm_lifetime_end_p0.Invoke(1L, &b);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
