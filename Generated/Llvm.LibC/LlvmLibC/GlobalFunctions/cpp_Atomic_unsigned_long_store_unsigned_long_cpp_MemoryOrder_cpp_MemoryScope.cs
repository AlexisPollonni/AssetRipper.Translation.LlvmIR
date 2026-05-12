using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicImE5storeEmNS0_11MemoryOrderENS0_11MemoryScopeE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned long>::store(unsigned long, __llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryScope)")]
internal static partial class cpp_Atomic_unsigned_long_store_unsigned_long_cpp_MemoryOrder_cpp_MemoryScope
{
	public unsafe static void Invoke(fputil_internal_FPStorage_v3nexn* @this, long rhs, MemoryOrder mem_ord, MemoryScope mem_scope)
	{
		long num = rhs;
		void* ptr = cpp_Atomic_unsigned_long_addressof_unsigned_long.Invoke(&@this->val);
		int num2 = cpp_Atomic_unsigned_long_order_cpp_MemoryOrder.Invoke(mem_ord);
		int num3 = cpp_Atomic_unsigned_long_scope_cpp_MemoryScope.Invoke(mem_scope);
		void* ptr2 = cpp_Atomic_unsigned_long_addressof_unsigned_long.Invoke(&num);
		unchecked
		{
			switch (num2)
			{
			default:
				switch (num3)
				{
				case 1:
					*(long*)ptr = *(long*)ptr2;
					break;
				default:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 2:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 3:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 4:
					*(long*)ptr = *(long*)ptr2;
					break;
				}
				break;
			case 3:
				switch (num3)
				{
				case 1:
					*(long*)ptr = *(long*)ptr2;
					break;
				default:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 2:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 3:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 4:
					*(long*)ptr = *(long*)ptr2;
					break;
				}
				break;
			case 5:
				switch (num3)
				{
				case 1:
					*(long*)ptr = *(long*)ptr2;
					break;
				default:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 2:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 3:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 4:
					*(long*)ptr = *(long*)ptr2;
					break;
				}
				break;
			}
		}
	}
}
