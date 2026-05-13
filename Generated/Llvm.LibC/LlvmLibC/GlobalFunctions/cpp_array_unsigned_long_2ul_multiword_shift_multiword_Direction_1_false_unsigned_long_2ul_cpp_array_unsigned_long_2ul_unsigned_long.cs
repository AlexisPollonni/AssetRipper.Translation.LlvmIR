using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EmLm2EEENS_3cpp5arrayIT1_XT2_EEES6_m")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned long, 2ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>, unsigned long)")]
internal static partial class cpp_array_unsigned_long_2ul_multiword_shift_multiword_Direction_1_false_unsigned_long_2ul_cpp_array_unsigned_long_2ul_unsigned_long
{
	public unsafe static Struct_fiz2nb Invoke([MangledName("array.coerce0")] long array, [MangledName("array.coerce1")] long offset, [MangledName("offset")] long WORD_BITS)
	{
		cpp_array_i3937k cpp_array_i3937k2 = default(cpp_array_i3937k);
		cpp_array_i3937k cpp_array_i3937k3 = default(cpp_array_i3937k);
		long num = 0L;
		long num2 = 0L;
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&cpp_array_i3937k3) = array;
			((long*)(&cpp_array_i3937k3))[1] = offset;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 64L;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 128L;
			llvm_lifetime_start_p0.Invoke(16L, &x);
			Struct_fiz2nb struct_fiz2nb = cpp_enable_if_sizeof_unsigned_int128_sizeof_cpp_array_unsigned_long_2ul_cpp_is_trivially_constructible_unsigned_int128_value_cpp_is_trivially_copyable_unsigned_int128_value_cpp_is_trivially_copyable_cpp_array_unsigned_long_2ul_value_unsigned_int128_type_cpp_bit_cast_unsigned_int128_cpp_array_unsigned_long_2ul_cpp_array_unsigned_long_2ul_const.Invoke(&cpp_array_i3937k3);
			Int128* num3 = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num3 = struct_fiz2nb2.field_0;
			byte* num4 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num4 = struct_fiz2nb3.field_1;
			x = @int;
			x = NumericHelper.ShiftRightLogical(x, (Int128)(UInt128)(ulong)WORD_BITS);
			Struct_fiz2nb struct_fiz2nb4 = cpp_enable_if_sizeof_cpp_array_unsigned_long_2ul_sizeof_unsigned_int128_cpp_is_trivially_constructible_cpp_array_unsigned_long_2ul_value_cpp_is_trivially_copyable_cpp_array_unsigned_long_2ul_value_cpp_is_trivially_copyable_unsigned_int128_value_cpp_array_unsigned_long_2ul_type_cpp_bit_cast_cpp_array_unsigned_long_2ul_unsigned_int128_unsigned_int128_const.Invoke(&x);
			InlineArray2_Int64* ptr = &cpp_array_i3937k2.Data;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
			llvm_lifetime_end_p0.Invoke(16L, &x);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_fiz2nb*)(&cpp_array_i3937k2.Data);
		}
	}
}
