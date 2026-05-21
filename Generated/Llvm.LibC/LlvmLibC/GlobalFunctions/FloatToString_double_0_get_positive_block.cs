using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_double_0_get_positive_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIdLi0EE18get_positive_blockEi")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<double, 0>::get_positive_block(int)")]
	public unsafe static int Invoke([MangledName("this")] void* This, [MangledName("block_index")][NativeType("int")] int Block_index)
	{
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_BigInt_khh67p llvm_libc_20_1_2_BigInt_khh67p = default(Llvm_libc_20_1_2_BigInt_khh67p);
		int num3 = 0;
		Llvm_libc_20_1_2_BigInt_khh67p llvm_libc_20_1_2_BigInt_khh67p2 = default(Llvm_libc_20_1_2_BigInt_khh67p);
		int num4 = 0;
		int num5 = 0;
		Int128 @int = default(Int128);
		unchecked
		{
			int result;
			if (((Llvm_libc_20_1_2_FloatToString_rwjwy3*)This)->field_1 >= -52)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (int)((((Llvm_libc_20_1_2_FloatToString_rwjwy3*)This)->field_1 >= 0) ? ((ulong)(uint)(((Llvm_libc_20_1_2_FloatToString_rwjwy3*)This)->field_1 + 15L) / 16uL) : 0L);
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (int)((long)(uint)num * 16L);
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_BigInt_khh67p);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_khh67p);
				*(long*)ptr = -6148914691236517206L;
				((long*)ptr)[1] = -6148914691236517206L;
				((long*)ptr)[2] = -6148914691236517206L;
				BigInt_192ul_false_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_khh67p);
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = 120;
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_BigInt_khh67p2);
				long num6 = (uint)num;
				long num7;
				checked
				{
					num7 = unchecked((ushort)((short*)POW10_OFFSET_175.Pointer)[num6]) + Block_index;
				}
				BigInt_192ul_false_unsigned_long_BigInt_3ul.Invoke(&llvm_libc_20_1_2_BigInt_khh67p2, (byte*)POW10_SPLIT_176.Pointer + (nint)num7 * sizeof(InlineArray3_Int64));
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_khh67p, &llvm_libc_20_1_2_BigInt_khh67p2, 24L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_BigInt_khh67p2);
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = 120 + num2 - ((Llvm_libc_20_1_2_FloatToString_rwjwy3*)This)->field_1;
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				Int128 mantissa = ((Llvm_libc_20_1_2_FloatToString_rwjwy3*)This)->Mantissa;
				int val = num4;
				@int = mantissa;
				num5 = Internal_mul_shift_mod_1e9.Invoke(*(long*)(&@int), ((long*)(&@int))[1], &llvm_libc_20_1_2_BigInt_khh67p, val);
				result = num5;
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_BigInt_khh67p);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				result = 0;
			}
			return result;
		}
	}
}
