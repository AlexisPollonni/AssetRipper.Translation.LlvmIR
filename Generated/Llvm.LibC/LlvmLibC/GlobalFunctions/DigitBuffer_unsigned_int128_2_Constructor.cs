using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DigitBuffer_unsigned_int128_2_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal11DigitBufferIoLi2EEC2EPKc")]
	[DemangledName("__llvm_libc_20_1_2_::internal::DigitBuffer<unsigned __int128, 2>::DigitBuffer(char const*)")]
	public unsafe static void Invoke([MangledName("this")] Internal_DigitBuffer_wtdk7c* This, [MangledName("str")][NativeType("char const*")] void* Str)
	{
		void* ptr = Str;
		InlineArray128_SByte* digits = &This->Digits;
		unchecked
		{
			sbyte* ptr2 = (sbyte*)digits + 128;
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
				DigitBuffer_unsigned_int128_2_push.Invoke(This, *(sbyte*)ptr);
			}
		}
	}
}
