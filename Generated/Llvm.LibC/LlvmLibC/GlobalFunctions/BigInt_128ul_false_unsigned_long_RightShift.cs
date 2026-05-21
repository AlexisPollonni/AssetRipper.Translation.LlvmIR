using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_RightShift
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmErsEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator>>(unsigned long) const")]
	public unsafe static Struct_fiz2nb Invoke(anon_izyfb7* @this, [NativeType("unsigned long")] long s)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		cpp_array_i3937k cpp_array_i3937k2 = default(cpp_array_i3937k);
		cpp_array_i3937k cpp_array_i3937k3 = default(cpp_array_i3937k);
		llvm_lifetime_start_p0.Invoke(16L, &cpp_array_i3937k2);
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_i3937k3, &((BigInt_qdkjbh*)@this)->val, 16L, isVolatile: false);
			Struct_fiz2nb struct_fiz2nb = multiword_shift_multiword_Direction_1_false_unsigned_long_2ul.Invoke(*(long*)(&cpp_array_i3937k3), ((long*)(&cpp_array_i3937k3))[1], s);
			InlineArray2_Int64* ptr = &cpp_array_i3937k2.Data;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			BigInt_128ul_false_unsigned_long_Constructor.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), &cpp_array_i3937k2);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_array_i3937k2);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.val.Data);
		}
	}
}
