using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DigitBuffer_unsigned_int128_10_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal11DigitBufferIoLi10EEC2EPKc")]
	[DemangledName("__llvm_libc_20_1_2_::internal::DigitBuffer<unsigned __int128, 10>::DigitBuffer(char const*)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_internal_DigitBuffer_wha8ym* This, [MangledName("str")][NativeType("char const*")] void* Str)
	{
		void* ptr = Str;
		InlineArray42_SByte* digits = &This->Digits;
		unchecked
		{
			sbyte* ptr2 = (sbyte*)digits + 42;
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
			This->Size = 0L;
			for (; *(sbyte*)ptr != 0; ptr = (byte*)ptr + 1)
			{
				DigitBuffer_unsigned_int128_10_push.Invoke(This, *(sbyte*)ptr);
			}
		}
	}
}
