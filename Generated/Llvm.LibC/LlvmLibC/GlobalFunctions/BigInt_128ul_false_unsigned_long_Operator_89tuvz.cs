using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_Operator_89tuvz
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmElSEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator<<=(unsigned long)")]
	[CleanName("BigInt_128ul_false_unsigned_long_Operator")]
	public unsafe static Anon_izyfb7* Invoke([MangledName("this")] Anon_izyfb7* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Cpp_array_i3937k cpp_array_i3937k = default(Cpp_array_i3937k);
		Cpp_array_i3937k cpp_array_i3937k2 = default(Cpp_array_i3937k);
		Llvm_lifetime_start_p0.Invoke(16L, &cpp_array_i3937k);
		unchecked
		{
			Llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_i3937k2, &((BigInt_qdkjbh*)This)->Val, 16L, isVolatile: false);
			Struct_fiz2nb struct_fiz2nb = Multiword_shift_multiword_Direction_0_false_unsigned_long_2ul.Invoke(*(long*)(&cpp_array_i3937k2), ((long*)(&cpp_array_i3937k2))[1], S);
			InlineArray2_Int64* ptr = &cpp_array_i3937k.Data;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(&((BigInt_qdkjbh*)This)->Val, &cpp_array_i3937k, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_array_i3937k);
			return This;
		}
	}
}
