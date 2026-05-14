using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIdLi0EE18get_positive_blockEi")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<double, 0>::get_positive_block(int)")]
internal static partial class FloatToString_double_0_get_positive_block_int
{
	public unsafe static int Invoke(void* @this, int block_index)
	{
		int num = 0;
		int num2 = 0;
		BigInt_khh67p bigInt_khh67p = default(BigInt_khh67p);
		int num3 = 0;
		BigInt_khh67p bigInt_khh67p2 = default(BigInt_khh67p);
		int num4 = 0;
		int num5 = 0;
		Int128 @int = default(Int128);
		unchecked
		{
			int result;
			if (((FloatToString_rwjwy3*)@this)->field_1 >= -52)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (int)((((FloatToString_rwjwy3*)@this)->field_1 >= 0) ? ((ulong)(uint)(((FloatToString_rwjwy3*)@this)->field_1 + 15L) / 16uL) : 0L);
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (int)((long)(uint)num * 16L);
				llvm_lifetime_start_p0.Invoke(24L, &bigInt_khh67p);
				sbyte* ptr = (sbyte*)(&bigInt_khh67p);
				*(long*)ptr = -6148914691236517206L;
				((long*)ptr)[1] = -6148914691236517206L;
				((long*)ptr)[2] = -6148914691236517206L;
				BigInt_192ul_false_unsigned_long_BigInt.Invoke(&bigInt_khh67p);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = 120;
				llvm_lifetime_start_p0.Invoke(24L, &bigInt_khh67p2);
				long num6 = (uint)num;
				long num7;
				checked
				{
					num7 = unchecked((ushort)((short*)POW10_OFFSET_175.Pointer)[num6]) + block_index;
				}
				BigInt_192ul_false_unsigned_long_BigInt_3ul_unsigned_long_const_3ul.Invoke(&bigInt_khh67p2, (byte*)POW10_SPLIT_176.Pointer + (nint)num7 * sizeof(InlineArray3_Int64));
				llvm_memcpy_p0_p0_i64.Invoke(&bigInt_khh67p, &bigInt_khh67p2, 24L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(24L, &bigInt_khh67p2);
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = 120 + num2 - ((FloatToString_rwjwy3*)@this)->field_1;
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				Int128 mantissa = ((FloatToString_rwjwy3*)@this)->mantissa;
				int val = num4;
				@int = mantissa;
				num5 = internal_mul_shift_mod_1e9_unsigned_int128_BigInt_192ul_false_unsigned_long_const_int.Invoke(*(long*)(&@int), ((long*)(&@int))[1], &bigInt_khh67p, val);
				result = num5;
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(24L, &bigInt_khh67p);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				result = 0;
			}
			return result;
		}
	}
}
