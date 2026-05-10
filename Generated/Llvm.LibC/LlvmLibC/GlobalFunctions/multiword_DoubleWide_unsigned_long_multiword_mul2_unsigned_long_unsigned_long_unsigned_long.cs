using System;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword4mul2ImEENS0_10DoubleWideIT_EES3_S3_")]
[DemangledName("__llvm_libc_20_1_2_::multiword::DoubleWide<unsigned long> __llvm_libc_20_1_2_::multiword::mul2<unsigned long>(unsigned long, unsigned long)")]
internal static partial class multiword_DoubleWide_unsigned_long_multiword_mul2_unsigned_long_unsigned_long_unsigned_long
{
	public unsafe static Struct_fiz2nb Invoke(long a, long b)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		unchecked
		{
			Int128 @int = NumericHelper.Multiply((Int128)(UInt128)(ulong)a, (Int128)(UInt128)(ulong)b);
			Struct_fiz2nb struct_fiz2nb = auto_multiword_split_unsigned_int128_unsigned_int128.Invoke(*(long*)(&@int), ((long*)(&@int))[1]);
			InlineArray2_Int64* ptr = &bigInt_qdkjbh.val.Data;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.val.Data);
		}
	}
}
