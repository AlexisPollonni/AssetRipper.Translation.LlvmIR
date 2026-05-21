using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_LeftShift
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmElsEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator<<(unsigned long) const")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] Anon_izyfb7* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_cpp_array_i3937k llvm_libc_20_1_2_cpp_array_i3937k = default(Llvm_libc_20_1_2_cpp_array_i3937k);
		Llvm_libc_20_1_2_cpp_array_i3937k llvm_libc_20_1_2_cpp_array_i3937k2 = default(Llvm_libc_20_1_2_cpp_array_i3937k);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_array_i3937k);
		unchecked
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_i3937k2, &((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val, 16L, isVolatile: false);
			Struct_fiz2nb struct_fiz2nb = Multiword_shift_multiword_Direction_0_false_unsigned_long_2ul.Invoke(*(long*)(&llvm_libc_20_1_2_cpp_array_i3937k2), ((long*)(&llvm_libc_20_1_2_cpp_array_i3937k2))[1], S);
			InlineArray2_Int64* ptr = &llvm_libc_20_1_2_cpp_array_i3937k.Data;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			BigInt_128ul_false_unsigned_long_Constructor.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), &llvm_libc_20_1_2_cpp_array_i3937k);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_array_i3937k);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_BigInt_qdkjbh.Val.Data);
		}
	}
}
