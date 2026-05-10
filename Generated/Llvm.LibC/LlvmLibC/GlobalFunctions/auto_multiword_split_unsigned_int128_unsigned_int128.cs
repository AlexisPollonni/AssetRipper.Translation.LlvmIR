using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword5splitIoEEDaT_")]
[DemangledName("auto __llvm_libc_20_1_2_::multiword::split<unsigned __int128>(unsigned __int128)")]
internal static partial class auto_multiword_split_unsigned_int128_unsigned_int128
{
	public unsafe static Struct_fiz2nb Invoke([MangledName("value.coerce0")] long value, [MangledName("value.coerce1")] long value_coerce1)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&@int) = value;
			((long*)(&@int))[1] = value_coerce1;
			Int128 int2 = @int;
			multiword_DoubleWide_unsigned_long_DoubleWide_unsigned_long_unsigned_long.Invoke(&bigInt_qdkjbh, (long)int2, (long)NumericHelper.ShiftRightLogical(int2, 64L));
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.val.Data);
		}
	}
}
