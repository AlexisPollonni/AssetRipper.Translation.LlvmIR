using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_is_zero
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmE7is_zeroEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::is_zero() const")]
	public unsafe static bool Invoke([MangledName("this")] Anon_izyfb7* This)
	{
		bool result = false;
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		unchecked
		{
			ptr = (void*)12297829382473034410uL;
			ptr = &((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = Array_unsigned_long_2ul_begin.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)ptr);
			Llvm_lifetime_start_p0.Invoke(8L, &ptr3);
			ptr3 = Array_unsigned_long_2ul_end.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)ptr);
			int num2;
			while (true)
			{
				if (ptr2 == ptr3)
				{
					num2 = 2;
					break;
				}
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = *(long*)ptr2;
				if (num != 0L)
				{
					result = false;
					num2 = 1;
				}
				else
				{
					num2 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num);
				switch (num2)
				{
				case 0:
					goto IL_00c7;
				}
				break;
				IL_00c7:
				ptr2 = (byte*)ptr2 + 8;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &ptr3);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			int num3 = num2;
			if (num3 != 2)
			{
				if (num3 != 1)
				{
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
	}
}
