using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_mul2_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword4mul2ImEENS0_10DoubleWideIT_EES3_S3_")]
	[DemangledName("__llvm_libc_20_1_2_::multiword::DoubleWide<unsigned long> __llvm_libc_20_1_2_::multiword::mul2<unsigned long>(unsigned long, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::multiword::DoubleWide<unsigned long>")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("a")][NativeType("unsigned long")] long A, [MangledName("b")][NativeType("unsigned long")] long B)
	{
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		unchecked
		{
			Int128 @int = NumericHelper.Multiply((Int128)(UInt128)(ulong)A, (Int128)(UInt128)(ulong)B);
			Struct_fiz2nb struct_fiz2nb = Multiword_split_unsigned_int128.Invoke(*(long*)(&@int), ((long*)(&@int))[1]);
			InlineArray2_Int64* ptr = &llvm_libc_20_1_2_BigInt_qdkjbh.Val.Data;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_BigInt_qdkjbh.Val.Data);
		}
	}
}
