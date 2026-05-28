using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_float_0_get_negative_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIfLi0EE18get_negative_blockEi")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<float, 0>::get_negative_block(int)")]
	public unsafe static int Invoke([MangledName("this")] FloatToString_vnf553* This, [MangledName("block_index")][NativeType("int")] int Block_index)
	{
		int num = 0;
		BigInt_khh67p bigInt_khh67p = default(BigInt_khh67p);
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		BigInt_khh67p bigInt_khh67p2 = default(BigInt_khh67p);
		int num5 = 0;
		int num6 = 0;
		Int128 @int = default(Int128);
		unchecked
		{
			int result;
			if (This->Exponent < 0)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (int)((ulong)checked(-This->Exponent) / 16uL);
				Llvm_lifetime_start_p0.Invoke(24L, &bigInt_khh67p);
				sbyte* ptr = (sbyte*)(&bigInt_khh67p);
				*(long*)ptr = -6148914691236517206L;
				((long*)ptr)[1] = -6148914691236517206L;
				((long*)ptr)[2] = -6148914691236517206L;
				BigInt_192ul_false_unsigned_long_Constructor.Invoke(&bigInt_khh67p);
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (int)(num * 16L);
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = 120;
				long num7 = num;
				if (Block_index < (byte)((sbyte*)MIN_BLOCK_2.Pointer)[num7])
				{
					result = 0;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					long num8 = num;
					int num11;
					long num12;
					checked
					{
						int num9 = unchecked((ushort)((short*)POW10_OFFSET_2.Pointer)[num8]) + Block_index;
						long num10 = num;
						num4 = num9 - unchecked((byte)((sbyte*)MIN_BLOCK_2.Pointer)[num10]);
						num11 = num4;
						num12 = num + 1;
					}
					if ((uint)num11 >= (uint)(ushort)((short*)POW10_OFFSET_2.Pointer)[num12])
					{
						result = 0;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(24L, &bigInt_khh67p2);
						long num13 = (uint)num4;
						BigInt_192ul_false_unsigned_long_BigInt_3ul.Invoke(&bigInt_khh67p2, (byte*)POW10_SPLIT_2.Pointer + (nint)num13 * sizeof(InlineArray3_Int64));
						Llvm_memcpy_p0_p0_i64.Invoke(&bigInt_khh67p, &bigInt_khh67p2, 24L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(24L, &bigInt_khh67p2);
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = checked(120 + (-This->Exponent - num2));
						Llvm_lifetime_start_p0.Invoke(4L, &num6);
						Int128 mantissa = This->Mantissa;
						int val = num5;
						@int = mantissa;
						num6 = Internal_mul_shift_mod_1e9.Invoke(*(long*)(&@int), ((long*)(&@int))[1], &bigInt_khh67p, val);
						result = num6;
						Llvm_lifetime_end_p0.Invoke(4L, &num6);
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(24L, &bigInt_khh67p);
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
