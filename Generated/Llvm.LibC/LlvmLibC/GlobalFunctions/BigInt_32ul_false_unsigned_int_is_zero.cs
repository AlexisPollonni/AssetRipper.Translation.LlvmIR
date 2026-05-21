using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_is_zero
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjE7is_zeroEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::is_zero() const")]
	public unsafe static bool Invoke(BigInt_vtm4cw* @this)
	{
		bool result = false;
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		int num = 0;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		unchecked
		{
			ptr = (void*)12297829382473034410uL;
			ptr = &@this->val;
			llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = array_unsigned_int_1ul_begin.Invoke((cpp_array_2v7m9i*)ptr);
			llvm_lifetime_start_p0.Invoke(8L, &ptr3);
			ptr3 = array_unsigned_int_1ul_end.Invoke((cpp_array_2v7m9i*)ptr);
			int num2;
			while (true)
			{
				if (ptr2 == ptr3)
				{
					num2 = 2;
					break;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = *(int*)ptr2;
				if (num != 0)
				{
					result = false;
					num2 = 1;
				}
				else
				{
					num2 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				switch (num2)
				{
				case 0:
					goto IL_00be;
				}
				break;
				IL_00be:
				ptr2 = (byte*)ptr2 + 4;
			}
			llvm_lifetime_end_p0.Invoke(8L, &ptr3);
			llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
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
