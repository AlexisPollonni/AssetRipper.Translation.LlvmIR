using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword18mul_add_with_carryImLm2EEET_RNS_3cpp5arrayIS2_XT0_EEES2_S2_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::multiword::mul_add_with_carry<unsigned long, 2ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>&, unsigned long, unsigned long)")]
internal static partial class unsigned_long_multiword_mul_add_with_carry_unsigned_long_2ul_cpp_array_unsigned_long_2ul_unsigned_long_unsigned_long
{
	public unsafe static long Invoke(cpp_array_i3937k* dst, long b, long c)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
		Struct_fiz2nb struct_fiz2nb = multiword_DoubleWide_unsigned_long_multiword_mul2_unsigned_long_unsigned_long_unsigned_long.Invoke(b, c);
		InlineArray2_Int64* ptr = &bigInt_qdkjbh.val.Data;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			long result = unsigned_long_multiword_add_with_carry_unsigned_long_2ul_2ul_cpp_array_unsigned_long_2ul_cpp_array_unsigned_long_2ul_const.Invoke(dst, (cpp_array_i3937k*)(&bigInt_qdkjbh));
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			return result;
		}
	}
}
