using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_split_unsigned_int128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword5splitIoEEDaT_")]
	[DemangledName("auto __llvm_libc_20_1_2_::multiword::split<unsigned __int128>(unsigned __int128)")]
	[return: NativeType("auto")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("value.coerce0")] long Value, [MangledName("value.coerce1")][NativeType("unsigned __int128")] long Value_coerce1)
	{
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = Value;
			((long*)(&@int))[1] = Value_coerce1;
			Int128 int2 = @int;
			DoubleWide_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh, (long)int2, (long)NumericHelper.ShiftRightLogical(int2, 64L));
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_BigInt_qdkjbh.Val.Data);
		}
	}
}
