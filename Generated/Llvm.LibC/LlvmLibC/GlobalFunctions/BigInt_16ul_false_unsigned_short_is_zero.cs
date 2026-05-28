using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_is_zero
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16ELb0EtE7is_zeroEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::is_zero() const")]
	public unsafe static bool Invoke([MangledName("this")] BigInt_ys7s55* This)
	{
		bool result = false;
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		short num = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		unchecked
		{
			ptr = (void*)12297829382473034410uL;
			ptr = &This->Val;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = Array_unsigned_short_1ul_begin.Invoke((Cpp_array_knh6hw*)ptr);
			Llvm_lifetime_start_p0.Invoke(8L, &ptr3);
			ptr3 = Array_unsigned_short_1ul_end.Invoke((Cpp_array_knh6hw*)ptr);
			int num2;
			while (true)
			{
				if (ptr2 == ptr3)
				{
					num2 = 2;
					break;
				}
				Llvm_lifetime_start_p0.Invoke(2L, &num);
				num = *(short*)ptr2;
				if ((ushort)num != 0)
				{
					result = false;
					num2 = 1;
				}
				else
				{
					num2 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(2L, &num);
				switch (num2)
				{
				case 0:
					goto IL_00c0;
				}
				break;
				IL_00c0:
				ptr2 = (byte*)ptr2 + 2;
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
