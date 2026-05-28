using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_string_token_true
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal12string_tokenILb1EEEPcS2_PKcPS2_")]
	[DemangledName("char* __llvm_libc_20_1_2_::internal::string_token<true>(char*, char const*, char**)")]
	[return: NativeType("char*")]
	public unsafe static void* Invoke([MangledName("src")][NativeType("char*")] void* Src, [MangledName("delimiter_string")][NativeType("char const*")] void* Delimiter_string, [MangledName("saveptr")][NativeType("char**")] void* Saveptr)
	{
		Cpp_array_jgy3xh cpp_array_jgy3xh = default(Cpp_array_jgy3xh);
		void* ptr = null;
		void* ptr2 = Src;
		void* ptr3 = Delimiter_string;
		unchecked
		{
			int value;
			if (ptr2 != null)
			{
				value = 0;
			}
			else
			{
				void* ptr4 = *(void**)Saveptr;
				ptr2 = ptr4;
				value = ((ptr4 == null) ? 1 : 0);
			}
			void* result;
			if (Details_expects_bool_condition_bool.Invoke((byte)value != 0, Expected: false))
			{
				result = null;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(32L, &cpp_array_jgy3xh);
				sbyte* ptr5 = (sbyte*)(&cpp_array_jgy3xh);
				*(long*)ptr5 = -6148914691236517206L;
				((long*)ptr5)[1] = -6148914691236517206L;
				((long*)ptr5)[2] = -6148914691236517206L;
				((long*)ptr5)[3] = -6148914691236517206L;
				Bitset_256ul_Constructor.Invoke(&cpp_array_jgy3xh);
				for (; *(sbyte*)ptr3 != 0; ptr3 = (byte*)ptr3 + 1)
				{
					Bitset_256ul_set.Invoke(&cpp_array_jgy3xh, *(sbyte*)ptr3);
				}
				for (; *(sbyte*)ptr2 != 0 && Bitset_256ul_test.Invoke(&cpp_array_jgy3xh, *(sbyte*)ptr2); ptr2 = (byte*)ptr2 + 1)
				{
				}
				if (*(sbyte*)ptr2 == 0)
				{
					*(void**)Saveptr = ptr2;
					result = null;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = ptr2;
					for (; *(sbyte*)ptr2 != 0; ptr2 = (byte*)ptr2 + 1)
					{
						if (Bitset_256ul_test.Invoke(&cpp_array_jgy3xh, *(sbyte*)ptr2))
						{
							*(sbyte*)ptr2 = 0;
							ptr2 = (byte*)ptr2 + 1;
							break;
						}
					}
					*(void**)Saveptr = ptr2;
					result = ptr;
					Llvm_lifetime_end_p0.Invoke(8L, &ptr);
				}
				Llvm_lifetime_end_p0.Invoke(32L, &cpp_array_jgy3xh);
			}
			return result;
		}
	}
}
