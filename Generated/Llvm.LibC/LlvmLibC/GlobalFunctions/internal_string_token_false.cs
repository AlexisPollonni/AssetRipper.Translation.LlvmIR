using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_string_token_false
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal12string_tokenILb0EEEPcS2_PKcPS2_")]
	[DemangledName("char* __llvm_libc_20_1_2_::internal::string_token<false>(char*, char const*, char**)")]
	[return: NativeType("char*")]
	public unsafe static void* Invoke([NativeType("char*")] void* src, [NativeType("char const*")] void* delimiter_string, [NativeType("char**")] void* saveptr)
	{
		cpp_array_jgy3xh cpp_array_jgy3xh2 = default(cpp_array_jgy3xh);
		void* ptr = null;
		void* ptr2 = src;
		void* ptr3 = delimiter_string;
		unchecked
		{
			int value;
			if (ptr2 != null)
			{
				value = 0;
			}
			else
			{
				void* ptr4 = *(void**)saveptr;
				ptr2 = ptr4;
				value = ((ptr4 == null) ? 1 : 0);
			}
			void* result;
			if (details_expects_bool_condition_bool.Invoke((byte)value != 0, expected: false))
			{
				result = null;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(32L, &cpp_array_jgy3xh2);
				sbyte* ptr5 = (sbyte*)(&cpp_array_jgy3xh2);
				*(long*)ptr5 = -6148914691236517206L;
				((long*)ptr5)[1] = -6148914691236517206L;
				((long*)ptr5)[2] = -6148914691236517206L;
				((long*)ptr5)[3] = -6148914691236517206L;
				bitset_256ul_Constructor.Invoke(&cpp_array_jgy3xh2);
				for (; *(sbyte*)ptr3 != 0; ptr3 = (byte*)ptr3 + 1)
				{
					bitset_256ul_set.Invoke(&cpp_array_jgy3xh2, *(sbyte*)ptr3);
				}
				if (*(sbyte*)ptr2 == 0)
				{
					*(void**)saveptr = ptr2;
					result = null;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = ptr2;
					for (; *(sbyte*)ptr2 != 0; ptr2 = (byte*)ptr2 + 1)
					{
						if (bitset_256ul_test.Invoke(&cpp_array_jgy3xh2, *(sbyte*)ptr2))
						{
							*(sbyte*)ptr2 = 0;
							ptr2 = (byte*)ptr2 + 1;
							break;
						}
					}
					*(void**)saveptr = ptr2;
					result = ptr;
					llvm_lifetime_end_p0.Invoke(8L, &ptr);
				}
				llvm_lifetime_end_p0.Invoke(32L, &cpp_array_jgy3xh2);
			}
			return result;
		}
	}
}
