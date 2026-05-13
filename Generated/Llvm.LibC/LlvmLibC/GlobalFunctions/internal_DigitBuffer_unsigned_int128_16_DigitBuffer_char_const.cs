using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal11DigitBufferIoLi16EEC2EPKc")]
[DemangledName("__llvm_libc_20_1_2_::internal::DigitBuffer<unsigned __int128, 16>::DigitBuffer(char const*)")]
internal static partial class internal_DigitBuffer_unsigned_int128_16_DigitBuffer_char_const
{
	public unsafe static void Invoke(internal_DigitBuffer_cze9ca* @this, void* str)
	{
		void* ptr = str;
		InlineArray32_SByte* digits = &@this->digits;
		unchecked
		{
			sbyte* ptr2 = (sbyte*)digits + 32;
			IntPtr intPtr = (nint)digits;
			while (true)
			{
				void* ptr3 = (void*)intPtr;
				*(sbyte*)ptr3 = 0;
				sbyte* ptr4 = (sbyte*)ptr3 + 1;
				if (ptr4 == ptr2)
				{
					break;
				}
				intPtr = (nint)ptr4;
			}
			@this->size = 0L;
			for (; *(sbyte*)ptr != 0; ptr = (byte*)ptr + 1)
			{
				internal_DigitBuffer_unsigned_int128_16_push_char.Invoke(@this, *(sbyte*)ptr);
			}
		}
	}
}
