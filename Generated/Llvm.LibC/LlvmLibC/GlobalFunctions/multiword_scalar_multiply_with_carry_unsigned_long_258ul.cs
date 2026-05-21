using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class multiword_scalar_multiply_with_carry_unsigned_long_258ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword26scalar_multiply_with_carryImLm258EEET_RNS_3cpp5arrayIS2_XT0_EEES2_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::multiword::scalar_multiply_with_carry<unsigned long, 258ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>&, unsigned long)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>&")] cpp_array_anzbtp* dst, [NativeType("unsigned long")] long x)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		void* ptr = null;
		void* ptr2 = null;
		void* ptr3 = null;
		void* ptr4 = null;
		long carry_in = 0L;
		llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr5 = (sbyte*)(&bigInt_qdkjbh);
			*(long*)ptr5 = -6148914691236517206L;
			((long*)ptr5)[1] = -6148914691236517206L;
			Accumulator_unsigned_long_Constructor.Invoke(&bigInt_qdkjbh);
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = (void*)12297829382473034410uL;
			ptr = dst;
			llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = array_unsigned_long_258ul_begin.Invoke((cpp_array_anzbtp*)ptr);
			llvm_lifetime_start_p0.Invoke(8L, &ptr3);
			for (ptr3 = array_unsigned_long_258ul_end.Invoke((cpp_array_anzbtp*)ptr); ptr2 != ptr3; ptr2 = (byte*)ptr2 + 8)
			{
				llvm_lifetime_start_p0.Invoke(8L, &ptr4);
				ptr4 = (void*)12297829382473034410uL;
				ptr4 = ptr2;
				llvm_lifetime_start_p0.Invoke(8L, &carry_in);
				carry_in = multiword_mul_add_with_carry_unsigned_long_2ul.Invoke((cpp_array_i3937k*)(&bigInt_qdkjbh), *(long*)ptr4, x);
				long num = Accumulator_unsigned_long_advance.Invoke(&bigInt_qdkjbh, carry_in);
				*(long*)ptr4 = num;
				llvm_lifetime_end_p0.Invoke(8L, &carry_in);
				llvm_lifetime_end_p0.Invoke(8L, &ptr4);
			}
			llvm_lifetime_end_p0.Invoke(8L, &ptr3);
			llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			long result = Accumulator_unsigned_long_carry.Invoke(&bigInt_qdkjbh);
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			return result;
		}
	}
}
