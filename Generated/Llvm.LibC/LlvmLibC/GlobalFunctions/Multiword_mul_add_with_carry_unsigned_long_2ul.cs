using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_mul_add_with_carry_unsigned_long_2ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword18mul_add_with_carryImLm2EEET_RNS_3cpp5arrayIS2_XT0_EEES2_S2_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::multiword::mul_add_with_carry<unsigned long, 2ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>&, unsigned long, unsigned long)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>&")] Cpp_array_i3937k* Dst, [MangledName("b")][NativeType("unsigned long")] long B, [MangledName("c")][NativeType("unsigned long")] long C)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		Llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
		Struct_fiz2nb struct_fiz2nb = Multiword_mul2_unsigned_long.Invoke(B, C);
		InlineArray2_Int64* ptr = &bigInt_qdkjbh.Val.Data;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			long result = Multiword_add_with_carry_unsigned_long_2ul_2ul.Invoke(Dst, (Cpp_array_i3937k*)(&bigInt_qdkjbh));
			Llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			return result;
		}
	}
}
