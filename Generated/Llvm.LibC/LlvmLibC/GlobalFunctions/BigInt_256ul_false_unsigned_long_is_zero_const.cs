using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE7is_zeroEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::is_zero() const")]
internal static partial class BigInt_256ul_false_unsigned_long_is_zero_const
{
	public unsafe static bool Invoke(BigInt_x9dsed* @this)
	{
		bool result = false;
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		unchecked
		{
			ptr = (void*)12297829382473034410uL;
			ptr = &@this->val;
			llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = cpp_array_unsigned_long_4ul_begin_const.Invoke((cpp_array_jgy3xh*)ptr);
			llvm_lifetime_start_p0.Invoke(8L, &ptr3);
			ptr3 = cpp_array_unsigned_long_4ul_end_const.Invoke((cpp_array_jgy3xh*)ptr);
			int num2;
			while (true)
			{
				if (ptr2 == ptr3)
				{
					num2 = 2;
					break;
				}
				llvm_lifetime_start_p0.Invoke(8L, &num);
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
				llvm_lifetime_end_p0.Invoke(8L, &num);
				switch (num2)
				{
				case 0:
					goto IL_00c7;
				}
				break;
				IL_00c7:
				ptr2 = (byte*)ptr2 + 8;
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
