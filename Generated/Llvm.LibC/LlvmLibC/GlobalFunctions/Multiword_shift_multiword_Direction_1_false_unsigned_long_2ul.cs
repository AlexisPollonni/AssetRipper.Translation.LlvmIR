using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_shift_multiword_Direction_1_false_unsigned_long_2ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EmLm2EEENS_3cpp5arrayIT1_XT2_EEES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned long, 2ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("array.coerce0")] long Array, [MangledName("array.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>")] long Offset, [MangledName("offset")][NativeType("unsigned long")] long WORD_BITS)
	{
		Cpp_array_i3937k cpp_array_i3937k = default(Cpp_array_i3937k);
		Cpp_array_i3937k cpp_array_i3937k2 = default(Cpp_array_i3937k);
		long num = 0L;
		long num2 = 0L;
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		unchecked
		{
			*(long*)(&cpp_array_i3937k2) = Array;
			((long*)(&cpp_array_i3937k2))[1] = Offset;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 64L;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 128L;
			Llvm_lifetime_start_p0.Invoke(16L, &x);
			Struct_fiz2nb struct_fiz2nb = Cpp_bit_cast_unsigned_int128_cpp_array_unsigned_long_2ul.Invoke(&cpp_array_i3937k2);
			Int128* num3 = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num3 = struct_fiz2nb2.field_0;
			byte* num4 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num4 = struct_fiz2nb3.field_1;
			x = @int;
			x = NumericHelper.ShiftRightLogical(x, (Int128)(UInt128)(ulong)WORD_BITS);
			Struct_fiz2nb struct_fiz2nb4 = Cpp_bit_cast_cpp_array_unsigned_long_2ul_unsigned_int128.Invoke(&x);
			InlineArray2_Int64* ptr = &cpp_array_i3937k.Data;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
			Llvm_lifetime_end_p0.Invoke(16L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_fiz2nb*)(&cpp_array_i3937k.Data);
		}
	}
}
